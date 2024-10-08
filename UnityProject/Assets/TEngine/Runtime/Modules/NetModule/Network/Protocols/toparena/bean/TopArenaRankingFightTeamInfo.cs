using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 巅峰竞技场同级积分排行榜出战队伍信息
 */
public class TopArenaRankingFightTeamInfo : IMessageSerialize 
{
	//1:副队，2：队长，3：总队
	int _type;	
	//小队战斗力
	int _fighting;	
	//出战角色列表
	List<TopArenaRankingFightersInfo> _fightCharacters = new List<TopArenaRankingFightersInfo>();
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//1:副队，2：队长，3：总队
		SerializeUtils.WriteInt(stream, _type);
		//小队战斗力
		SerializeUtils.WriteInt(stream, _fighting);
		//出战角色列表
		SerializeUtils.WriteShort(stream, (short)_fightCharacters.Count);

		foreach (var element in _fightCharacters)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//1:副队，2：队长，3：总队
		_type = SerializeUtils.ReadInt(stream);
		//小队战斗力
		_fighting = SerializeUtils.ReadInt(stream);
		//出战角色列表
		int _fightCharacters_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _fightCharacters_length; ++i) 
		{
			_fightCharacters.Add(SerializeUtils.ReadBean<TopArenaRankingFightersInfo>(stream));
		}
	}
	
	/**
	 * 1:副队，2：队长，3：总队
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	/**
	 * 小队战斗力
	 */
	public int Fighting
	{
		set { _fighting = value; }
	    get { return _fighting; }
	}
	
	/**
	 * get 出战角色列表
	 * @return 
	 */
	public List<TopArenaRankingFightersInfo> GetFightCharacters()
	{
		return _fightCharacters;
	}
	
	/**
	 * set 出战角色列表
	 */
	public void SetFightCharacters(List<TopArenaRankingFightersInfo> fightCharacters)
	{
		_fightCharacters = fightCharacters;
	}
	
}