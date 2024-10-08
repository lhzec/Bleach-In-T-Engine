using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 灵力修炼最高纪录排名信息
 */
public class AdvanceTrialRankInfo : IMessageSerialize 
{
	//已通过的灵力修炼编号
	int _advanceTrialId;	
	//玩家名字
	string _playerName;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//已通过的灵力修炼编号
		SerializeUtils.WriteInt(stream, _advanceTrialId);
		//玩家名字
		SerializeUtils.WriteString(stream, _playerName);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//已通过的灵力修炼编号
		_advanceTrialId = SerializeUtils.ReadInt(stream);
		//玩家名字
		_playerName = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * 已通过的灵力修炼编号
	 */
	public int AdvanceTrialId
	{
		set { _advanceTrialId = value; }
	    get { return _advanceTrialId; }
	}
	
	/**
	 * 玩家名字
	 */
	public string PlayerName
	{
		set { _playerName = value; }
	    get { return _playerName; }
	}
	
}