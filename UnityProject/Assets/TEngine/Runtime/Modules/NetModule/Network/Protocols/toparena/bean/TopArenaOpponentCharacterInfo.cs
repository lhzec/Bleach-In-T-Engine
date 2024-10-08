using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 巅峰竞技场出战队伍
 */
public class TopArenaOpponentCharacterInfo : IMessageSerialize 
{
	//1 副队 2队长 3总队长
	int _type;	
	//0 未打 1胜利 2失败
	int _fightResult;	
	//对手角色列表
	List<ArenaFightCharacterInfo> _oppoCharacters = new List<ArenaFightCharacterInfo>();
	//灵魂共鸣技能
	List<SoulResonance> _resonanceSkills = new List<SoulResonance>();
    //真灵院书籍列表
    List<CollegeBook> _collegeBookList = new List<CollegeBook>();
    //书院等级
    int _collegeStage;	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//1 副队 2队长 3总队长
		SerializeUtils.WriteInt(stream, _type);
		//0 未打 1胜利 2失败
		SerializeUtils.WriteInt(stream, _fightResult);
		//对手角色列表
		SerializeUtils.WriteShort(stream, (short)_oppoCharacters.Count);

		foreach (var element in _oppoCharacters)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//灵魂共鸣技能
		SerializeUtils.WriteShort(stream, (short)_resonanceSkills.Count);

		foreach (var element in _resonanceSkills)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
        //真灵院书籍列表
        SerializeUtils.WriteShort(stream, (short)_collegeBookList.Count);

        foreach (var element in _collegeBookList)
        {
            SerializeUtils.WriteBean(stream, element);
        }
        //书院等级
        SerializeUtils.WriteInt(stream, _collegeStage);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//1 副队 2队长 3总队长
		_type = SerializeUtils.ReadInt(stream);
		//0 未打 1胜利 2失败
		_fightResult = SerializeUtils.ReadInt(stream);
		//对手角色列表
		int _oppoCharacters_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _oppoCharacters_length; ++i) 
		{
			_oppoCharacters.Add(SerializeUtils.ReadBean<ArenaFightCharacterInfo>(stream));
		}
		//灵魂共鸣技能
		int _resonanceSkills_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _resonanceSkills_length; ++i) 
		{
			_resonanceSkills.Add(SerializeUtils.ReadBean<SoulResonance>(stream));
		}
        //真灵院书籍列表
        int _collegeBookList_length = SerializeUtils.ReadShort(stream);
        for (int i = 0; i < _collegeBookList_length; ++i)
        {
            _collegeBookList.Add(SerializeUtils.ReadBean<CollegeBook>(stream));
        }
        //书院等级
        _collegeStage = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 1 副队 2队长 3总队长
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	/**
	 * 0 未打 1胜利 2失败
	 */
	public int FightResult
	{
		set { _fightResult = value; }
	    get { return _fightResult; }
	}
	
	/**
	 * get 对手角色列表
	 * @return 
	 */
	public List<ArenaFightCharacterInfo> GetOppoCharacters()
	{
		return _oppoCharacters;
	}
	
	/**
	 * set 对手角色列表
	 */
	public void SetOppoCharacters(List<ArenaFightCharacterInfo> oppoCharacters)
	{
		_oppoCharacters = oppoCharacters;
	}
	
	/**
	 * get 灵魂共鸣技能
	 * @return 
	 */
	public List<SoulResonance> GetResonanceSkills()
	{
		return _resonanceSkills;
	}
	
	/**
	 * set 灵魂共鸣技能
	 */
	public void SetResonanceSkills(List<SoulResonance> resonanceSkills)
	{
		_resonanceSkills = resonanceSkills;
	}
    /**
 * get 真灵院书籍列表
 * @return 
 */
    public List<CollegeBook> GetCollegeBookList()
    {
        return _collegeBookList;
    }

    /**
     * set 真灵院书籍列表
     */
    public void SetCollegeBookList(List<CollegeBook> collegeBookList)
    {
        _collegeBookList = collegeBookList;
    }

    /**
     * 书院等级
     */
    public int CollegeStage
    {
        set { _collegeStage = value; }
        get { return _collegeStage; }
    }
}