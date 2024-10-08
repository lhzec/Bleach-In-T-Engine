using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 竞技场排行榜出战角色信息
 */
public class ArenaFightCharacterInfo : IMessageSerialize 
{
	//角色id
	int _characterId;	
	//角色阶级
	int _characterStageLevel;	
	//角色成长等级
	int _growthLevel;	
	//战斗力
	int _fighting;	
	//被动技能（援护技能）
	List<FightSkillInfo> _assistSkills = new List<FightSkillInfo>();
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//角色id
		SerializeUtils.WriteInt(stream, _characterId);
		//角色阶级
		SerializeUtils.WriteInt(stream, _characterStageLevel);
		//角色成长等级
		SerializeUtils.WriteInt(stream, _growthLevel);
		//战斗力
		SerializeUtils.WriteInt(stream, _fighting);
		//被动技能（援护技能）
		SerializeUtils.WriteShort(stream, (short)_assistSkills.Count);

		foreach (var element in _assistSkills)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//角色id
		_characterId = SerializeUtils.ReadInt(stream);
		//角色阶级
		_characterStageLevel = SerializeUtils.ReadInt(stream);
		//角色成长等级
		_growthLevel = SerializeUtils.ReadInt(stream);
		//战斗力
		_fighting = SerializeUtils.ReadInt(stream);
		//被动技能（援护技能）
		int _assistSkills_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _assistSkills_length; ++i) 
		{
			_assistSkills.Add(SerializeUtils.ReadBean<FightSkillInfo>(stream));
		}
	}
	
	/**
	 * 角色id
	 */
	public int CharacterId
	{
		set { _characterId = value; }
	    get { return _characterId; }
	}
	
	/**
	 * 角色阶级
	 */
	public int CharacterStageLevel
	{
		set { _characterStageLevel = value; }
	    get { return _characterStageLevel; }
	}
	
	/**
	 * 角色成长等级
	 */
	public int GrowthLevel
	{
		set { _growthLevel = value; }
	    get { return _growthLevel; }
	}
	
	/**
	 * 战斗力
	 */
	public int Fighting
	{
		set { _fighting = value; }
	    get { return _fighting; }
	}
	
	/**
	 * get 被动技能（援护技能）
	 * @return 
	 */
	public List<FightSkillInfo> GetAssistSkills()
	{
		return _assistSkills;
	}
	
	/**
	 * set 被动技能（援护技能）
	 */
	public void SetAssistSkills(List<FightSkillInfo> assistSkills)
	{
		_assistSkills = assistSkills;
	}
	
}